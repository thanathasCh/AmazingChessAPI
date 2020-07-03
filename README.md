Amazing Chess API
====

This project is Backend service, crated by .NET Core 3.x. It should be used
along with Amazing Chess (Android Application, https://github.com/thanathasCh/AmazingChess)

Installation
---
In order to run project, you need .NET Core version 3.x. After you clone the project, you have to run the following code
1. Change database connection string in `appsetting.Development.json` to your own database
2. Create database by running `dotnet ef database update`
3. Run the project `dotnet run`

You will have localhost url to send request. However, if you want to connect it to android application,
you may have to create your own backend service and run this project. 
There are many services you can use from Azure, AWS or GCP. But for making a quick test, 
I would recomend to use `ngrok` to create tunnel to your localhost. And change the url in android project.

After you install `ngrok`, you can simply run `ngrok http 5001`. If the url keeps return 502: Bad Gateway, you might have to run `ngrok http https:localhost:5001 -host-header="localhost:5001"` instead. 

Remark
---
This project is still under developing along with Amazing Chess (Android Application, https://github.com/thanathasCh/AmazingChess)