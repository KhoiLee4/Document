static async Task Main(string[] args)
{
    string url = "https://github.com/microsoft/vscode/archive/1.48.0.tar.gz";
    var taskdonload = DownloadAsync.DownloadFile(url);
    //..
    Console.WriteLine("Làm gì đó khi file đang tải");
    //..
    await taskdonload;
    Console.WriteLine("Làm gì đó khi file tải xong");
}