# Blazingdocs UI Client

Im Client-Verzeichnis mit Node.js 24 und pnpm 11 starten:

```sh
pnpm install --frozen-lockfile
pnpm dev
```

Die von Vite ausgegebene lokale Adresse öffnen und über **PDF öffnen** einen Scan auswählen.
Die Vorschau verarbeitet die Datei lokal. Eine eingebettete Textebene lässt sich markieren
und auf der angezeigten Seite mit der Browser-Suche durchsuchen.

Für den ASP.NET-Core-Host zuerst hier `pnpm build` ausführen. Der Build prüft
die TypeScript-Typen und schreibt den Client einschließlich PDF-Worker nach
`../blazingdocs.UI.Server/wwwroot/client`. Anschließend den Host wie üblich
starten oder veröffentlichen.
