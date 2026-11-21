# blazingdocs
Awesome document management for the user who's got nothing else to do

## Lokale Entwicklung

Die fünf C#-Projekte verwenden .NET 11. Im Hauptverzeichnis:

```powershell
dotnet build blazingdocs.slnx -c Release
dotnet run --project 01_Execution/blazingdocs.UI.Server
```

Für Datenbankzugriffe den SQL-Server-Verbindungsstring über
`ConnectionStrings__Blazingdocs` oder in der Development-Umgebung per User Secrets
setzen. Beim Start muss `StorageRootPath` auf einen absoluten Pfad der jeweiligen
Plattform zeigen, etwa `D:/blazingdocs-storage` unter Windows oder
`/mnt/nas/blazingdocs` unter Linux. Der Server benötigt Schreibzugriff.
In der Datenbank steht nur der Pfad darunter, etwa `2026/11/21/abcd1234.xyz`.
Beim Umzug des Bestands die Verzeichnisstruktur beibehalten und den neuen
Hauptordner konfigurieren.

```powershell
$server = '01_Execution/blazingdocs.UI.Server'
dotnet user-secrets set "ConnectionStrings:Blazingdocs" "<eigener SQL-Server-Verbindungsstring>" --project $server
dotnet tool restore
dotnet ef migrations list --project 03_Infrastructure/blazingdocs.Repositories --startup-project $server -- --environment Development
```

Der Vite-Build im Verzeichnis `01_Execution/blazingdocs.UI.Client` schreibt
die React-Anwendung nach `wwwroot/client` im Serverprojekt. Für einen Publish
mit Oberfläche zuerst dort `npm run build` mit installierten npm-Abhängigkeiten
ausführen, danach im Hauptverzeichnis `dotnet publish 01_Execution/blazingdocs.UI.Server -c Release`.
