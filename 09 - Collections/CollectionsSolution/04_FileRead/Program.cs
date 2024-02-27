using System;

DateTime date = DateTime.Now;

Random rnd = new Random();
List<LottoPlayer> lottoPlayers = await FileService.ReadFromFileV2Async("adatok");

int randomNumber = rnd.Next(1, 46);

//1 - Írjuk ki a képernyőre az össz adatot
lottoPlayers.WriteCollectionToConsole();

//2 - Random számok segítségével generáljuk le a napi 7 nyerő számot és írjuk őket egy szöveges állományba, melynek az aktuális nap lesz a neve
List<int> lottoNumbers = GenerateLottoNumbers(randomNumber);

int dayNumber = date.Now.DayOfWeek;

await FileService.WriteToFileAsync($"{actualDay}", lottoNumbers);

//4 - Keressük ki, van(ak)-e 7 találatos szelvény(ek), ha igen írjuk ki a nyertesek nevét a nyertesek-{mai dátum}.txt állományba.
bool isThereLuckyWinner = lottoPlayers.Any(x => GuessCount(lottoNumbers, x.Guess) == 7);

List<LottoPlayer> winners = lottoPlayers.Where(x => isThereLuckyWinner == true).ToList();

await FileService.WriteToFileAsync($"{date}", winners);


//5 - Keressük ki, hogy a befizetett játékosok hány találatot értek el,
//és mentsük el a talalatok-{mai dátum}.txt állományba a játékos nevét és a találatainak számát
List<int> GenerateLottoNumbers(int rnd){
    List<int> lottoNumbers = new List<int>();

    do
    {
        if (!lottoNumbers.Contains(rnd))
        {
            lottoNumbers.Add(rnd);
        }
    }
    while(lottoNumbers.Count <= 7);

    Thread.Sleep(100);

    return lottoNumbers;
}
int GuessCount(List<int> lottoNumbers, List<int> playerGuasses) => lottoNumbers.Intersect(playerGuasses).Count();