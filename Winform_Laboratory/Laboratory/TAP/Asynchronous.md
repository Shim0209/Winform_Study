﻿비동기 프로그래밍
===============

## - 비동기 프로그래밍 
> 비동기 프로그래밍은 중앙처리장치를 효율적으로 사용하기 위한 기술이다.
중앙처리장치는 매 초마다 정말 많은 작업을 요청받고 처리한다. 데이터를 읽거나 쓰거나, 네트워크 통신을 주거나 받거나, 화면 픽셀을 계산하거나 모두 중앙처리장치의 허가와 지도가 필요하다. 이렇게 바쁜 중앙처리장치에게 현재 입출력 작업이 완료되길 기다리게 하는건 정말 비효율적이다. 그래서 개발자는 중앙처리장치가 비효율적으로 낭비되지 않도록 비동기 프로그래밍 기술을 사용하여, 중앙처리장치가 입출력을 기다리는 대신 다른 업무를 처리하도록 하고 입출력이 완료되었다는 메세지를 받은 뒤에 기존 작업을 다시 시작하도록 프로그래밍한다.

## - 등장 배경
기본적으로 프로그램은 코드 순서에 따라 순차적으로 실행된다. 그래서 코드 중간에 시간이 오래 걸리는 작업이 있으면 프로그램은 순차적으로 코드를 진행해야 하니까, 다른 작업은 처리하지 않게 된다. 사용자 입장에선 몇 초 동안이라도 프로그램이 반응하지 않는다면, 프로그램이 살았는지 죽었는지 알 길이 없다. 사용자는 인내심이 바닥나면 프로그램을 강제 종료하고 다시 시도해본다. 하지만 프로그램 버그가 아니므로 같은 문제를 겪게 될 것이고 사용자는 프로그램이 잘못되었다고 판단하게 된다.
웹 서버도 마찬가지다. 만약 웹 서버가 사용자의 요구를 처리하느라 사용자에게 반응하지 않는다면, 사용자는 서비스가 정상적으로 동작하는지 의심하게 된다. 예를 들어, 사용자가 인기있는 콘서트 티켓을 예약하는데 서비스가 30초나 응답이 없다면 정말 티켓이 예약되고 있는건지 지금이라도 새로고침하고 새로 예약해야 하는지 고통받게 된다. 사용자는 고통받는 매순간마다 다음부턴 다른 서비스를 사용하리라 다짐하고 있을 것이다. 이렇게 서비스가 사용자에게 무응답하여 겪는 불편을 해소하기 위해, 서비스가 사용자에게 적극적으로 반응할 수 있도록 비동기 프로그래밍 기술이 등장하게 된다.

## - C# 에서 비동기 프로그래밍
C# 에서 비동기 프로그래밍은 [작업 기반 비동기 패턴 Task-based asynchronous pattern (TAP)](https://docs.microsoft.com/ko-kr/dotnet/standard/asynchronous-programming-patterns/task-based-asynchronous-pattern-tap) 을 기반으로 async / await 키워드로 구현할 수 있도록 제공하고 있다.
개발자는 아래 개념만 이해하면 비동기 프로그래밍을 과거와 달리 손쉽게 구현할 수 있다.

1. 작업 기반 비동기 패턴(TAP)
2. async / await 사용법

### 작업 기반 비동기 패턴 Task-based asynchronous pattern TAP
> 작업 기반 비동기 패턴은 Task 클래스로 비동기 작업을 통제하는 패턴이다.
> Task 클래스는 비동기 작업을 모델링하여 작업을 통제하는 클래스이다.
Task 클래스로 비동기 작업의 상태를 확인할 수도 있고, 비동기 작업을 시작하거나 취소하거나 종료할 수도 있다. 당연히 예외도 처리 가능하다.Task 클래스는 내부적으로ThreadPool 큐라는 스레드 관리 서비스에 등록되어 실행된다.ThreadPool 은 개발자를 대신해 스레드 수를 파악하고 실행을 조정하며 처리량을 최대화할 수 있도록 부하를 분산시킨다. 작업 기반 비동기 패턴은 Task 클래스를 중심으로 아래와 같이 구성된다.

|비동기 작업 CLASS|설명|
|---|---|
|Task|Class 타입으로, 반환값이 없는 기본적인 비동기 작업|
|Task<TResult>|Class 타입으로, TResult를 반환하는 비동기 작업|
|ValueTask|Struct 타입으로, 한번만 대기할 수 있는 비동기 작업|
|ValueTask<TResult>|Struct 타입으로, TResult를 반환하는 비동기 작업|

### async 한정자
> 비동기 작업을 진행할 메서드를 지정하는 한정자
```C#
public async Task<int> ExampleMethodAsync()
{
    // ...
}
```
async로 지정된 메서드는 반드시 비동기 작업을 통제하는 클래스(Task)를 반환하는 함수여야 한다. void도 반환 가능하지만, await로 지정해 코드를 실행하면, 비동기 작업을 모델링하지 않기 때문에 예외처리나 비동기 작업을 통제할 수 없게 된다. void는 이벤트 처리기를 정의할 때만 사용하자. 그리고 내부 코드 흐름은 await 연산자에 따라 변화하게 된다. 여기서는 "비동기 작업을 async 한정자로 표시하는구나"로 이해하고 자세한 사항은 예제 코드를 보며 이해해보자.

### await 연산자
> 비동기 작업의 실행흐름을 통제하는 연산자
await 연산자의 위치에 따라 비동기 작업 수행 흐름이 결정된다. 메서드 실행 도중 await 연산자를 만나게 되면 현재 실행 중인 async 메서드를 호출한 주체에게 현재 스레드의 실행 흐름을 넘기면서, await 대상 코드를 새로운 스레드로 실행한다. await으로 실행된 스레드가 완료되어 Task를 반환하면 실행 흐름을 다시 취득해 나머지 코드를 실행한다.

### async 및 await를 사용한 비동기 프로그래밍
async 메서드 내에 데이터 입출력(I/O) 관련 코드는 Task 클래스를 await 하여 비동기 작업을 수행하고, 중앙처리장치(CPU) 연산을 비동기로 처리할 때는 Task.Run 메서드를 await하여 백그라운드 스레드에서 비동기 작업을 수행한다.

### I/O 비동기 처리 예제: 웹 서비스에서 데이터 다운로드
```C#
private readonly HttpClient _httpClient = new HttpClient();

downloadButton.Clicked += async (o, e) =>
{
    // 웹 서비스로 데이터를 다운로드 받는 동안,
    // await 연산자로 인해 실행 흐름은 UI 스레드에게 넘어간다.
    var stringData = await _httpClient.GetStringAsync(URL);
    DoSomethingWithData(stringData);
};
```

### CPU 바인딩된 예제: 게임데 대한 계산 수행
```C#
calculateButton.Clicked += async (o, e) =>
{
    // 백그라운드를 생성해 비동기 작업을 진행하고,
    // await 연산자로 인해 실행 흐름은 UI 스레드에게 넘어간다.
    var damageResult = await Task.Run(() => CalculateDamageDone());
    DisplayDamage(damageResult);
};
```

## - 마이크로소프트에서 공식적으로 제공하는 비동기 설계 예제 분석
아래 아침 식사를 준비하는 과정을 프로그램으로 작성한다고 가정해보자.
1. 커피 한 잔을 따른다.
2. 계란 프라이 두 개를 요리한다.
3. 베이컨 세 조각을 굽는다.
4. 토스트 두 조각을 굽는다.
5. 토스트에 버터와 잼을 바른다.
6. 오렌지 주스 한 잔을 따른다.

### 실행 흐름 차단
아래 코드는 기존의 동기 프로그래밍 방법으로 하나 하나 정성껏 순서대로 아침 식사를 준비한다.
```C#
static void Main(stirng[] args)
{
    Coffee cup = PourCoffee();
    Console.WriteLine("coffee is ready");
    Egg eggs = FryEggs(2);
    Console.WriteLine("eggs are ready");
    Bacon bacon = FryBacon(3);
    Console.WriteLine("bacon is ready");
    Toast toast = ToastBread(2);
    ApplyButter(toast);
    ApplyJam(toast);
    Console.WriteLine("toast is ready");
    Juice oj = PourOJ();
    Console.WriteLine("oj is ready");

    Console.WriteLine("Breakfast is ready!");
}
```

### 실행 흐름을 차단하는 대신에 대기
제일 간단하게 비동기 프로그래밍을 도입하는 방법은 async / await를 적용해서 흐름이 차단되지 않도록 하는 것이다.
```C#
static async Task Main(string[] args)
{
    Coffee cup = PourCoffee();
    Console.WriteLine("coffee is ready");
    Egg eggs = await FryEggs(2);
    Console.WriteLine("eggs are ready");
    Bacon bacon = await FryBacon(3);
    Console.WriteLine("bacon is ready");
    Toast toast = await ToastBread(2);
    ApplyButter(toast);
    ApplyJam(toast);
    Console.WriteLine("toast is ready");
    Juice oj = PourOJ();
    Console.WriteLine("oj is ready");

    Console.WriteLine("Breakfast is ready!");
}
```
이제 계란 프라이를 준비하거나 베이컨을 구울 때, 실행 흐름을 Main 함수를 호출한 함수에게 넘겨줄 수 있다. 즉 아침 식사를 준비하는 대신 다른 작업을 진행할 수 있다. 하지만 아침 식사 준비 단계는 여전히 하나 하나 준비하게 된다.

### 동시에 작업 시작
이제 계란 프라이를 요리하면서 베이컨도 굽고 토스트도 구워보자.
```C#
static async Task Main(string[] args)
{
    Coffee cup = PourCoffee();
    Console.WriteLine("coffee is ready");
    Task<Egg> eggTask = FryEggs(2);
    Task<Bacon> baconTask = FryBacon(3);
    Task<Toast> toastTask = ToastBread(2);
    Toast toast = await toastTask;
    ApplyButter(toast);
    ApplyJam(toast);
    Console.WriteLine("toast is ready");
    Juice oj = PourOJ();
    Console.WriteLine("oj is ready");

    Egg eggs = await eggTask;
    Console.WriteLine("eggs are ready");
    Bacon bacon = await baconTask;
    Console.WriteLine("bacon is ready");

    Console.WriteLine("Breakfast is ready!");
}
```
FryEggs 함수와 FryBacon 함수와 ToastBread 함수를 각각 실행하고, 비동기 작업을 Task 클래스에 저장한다. 그리고 비동기 작업의 결과가 필요할 때에 await 연산자를 사용해 작업이 완료되어 결과가 반환되기를 기다린다. 토스트에 버터와 잼을 발라야 하니까, 다음 코드 라인에서 toastTask 비동기 작업이 완료되기를 await 하고, 대기하는 동안은 실행 흐름을 아침 식사 준비말고 다른 작업에 넘긴다.
코드를 이해했다면, 토스트를 구운 다음에는 반드시 버터와 잼을 발라야 한다는 사실을 깨달을 수 있다. 그렇다면 토스트를 굽고 버터와 잼을 바르는 단계를 하나의 메서드로 구현해보자.

### 작업 구성
```C#
async Task<Toast> MakeToastWithButterAndJamAsync(int number)
{
    var toast = await ToastBreadAsync(number);
    ApplyButter(toast);
    ApplyJam(toast);
    return toast;
}
```
위와 같이 토스트 준비를 하나의 작업으로 구성하고, Main 함수에 적용해보자.
```C#
static async Task Main(string[] args)
{
    Coffee cup = PourCoffee();
    Console.WriteLine("coffee is ready");
    var eggsTask = FryEggsAsync(2);
    var baconTask = FryBaconAsync(3);
    var toastTask = MakeToastWithButterAndJamAsync(2);

    var eggs = await eggsTask;
    Console.WriteLine("eggs are ready");
    var bacon = await baconTask;
    Console.WriteLine("bacon is ready");
    var toast = await toastTask;
    Console.WriteLine("toast is ready");
    Juice oj = PourOJ();
    Console.WriteLine("oj is ready");

    Console.WriteLine("Breakfast is ready!");

    async Task<Toast> MakeToastWithButterAndJamAsync(int number)
    {
        var toast = await ToastBreadAsync(number);
        ApplyButter(toast);
        ApplyJam(toast);
        return toast;
    }
}
```
이제 전과 달리, 토스트 두 조각 모두 굽는 걸 기다릴 필요없이 바로 계란 후라이를 요리할 수 있고 토스트가 완성되면 그 때 버터와 잼을 바를 수 있다. 즉 Main 메서드가 MakeToastWithButterAndJamAsync 메서드가 완료되길 기다릴 필요없이, 바로 다음 코드를 실행한다. 그리고 MakeToastWithButterAndJamAsync 메서드에서 ToastBreadAsync 메서드가 완료될 때, ApplyButter 메서드와 ApplyJam 메서드를 실행한다.
마지막으로 비동기 작업을 대기하는 방법을 효율적으로 재구성해보자.

### 효율적인 비동기 작업 대기
```C#
static async Task Main(string[] args)
{
    Coffee cup = PourCoffee();
    Console.WriteLine("coffee is ready");
    var eggsTask = FryEggsAsync(2);
    var baconTask = FryBaconAsync(3);
    var toastTask = MakeToastWithButterAndJamAsync(2);

    var allTasks = new List<Task>{eggsTask, baconTask, toastTask};
    while (allTasks.Any())
    {
        Task finished = await Task.WhenAny(allTasks);
        if (finished == eggsTask)
        {
            Console.WriteLine("eggs are ready");
        }
        else if (finished == baconTask)
        {
            Console.WriteLine("bacon is ready");
        }
        else if (finished == toastTask)
        {
            Console.WriteLine("toast is ready");
        }
        allTasks.Remove(finished);
    }
    Console.WriteLine("Breakfast is ready!");

    async Task<Toast> MakeToastWithButterAndJamAsync(int number)
    {
        var toast = await ToastBreadAsync(number);
        ApplyButter(toast);
        ApplyJam(toast);
        return toast;
    }
}
```
예제 코드는 모든 비동기 작업을 실행시킨 뒤, while 문 내에서 Task.WhenAny를 사용해 전체 비동기 작업 중 하나라도 완료되길 await 한다. 하나의 작업이라도 완료되면, 실행 흐름을 취득해 완료된 작업과 연관된 코드를 실행시키고 나서 실행 흐름을 다시 await 한다.

## - C#이 구현한 비동기 작업에 대한 개념
C# 의 비동기 모델은 Futures and promises 개념을 프레임워크로 구현했다.
1. Futures는 "지금은 없지만 언젠가 사용가능해질 데이터를 기다리는 상자"다.
2. Promises는 "Futures에 데이터를 제공할 작업 프로세스"다.
3. Task클래스는 Futures고, async 메서드는 Promises다.
> 즉 데이터를 Future(미래)에 제공할 것이라고 Promise(약속)한다.
> 프로그램은 Promise(약속)을 믿고 Future(미래)에 데이터가 제공되길 대기하며, 다른 작업을 수행한다.