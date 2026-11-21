# Blazingdocs: Hinweise für KI-Assistenten

## Projektkontext

Lies vor fachlichen oder architektonischen Änderungen [docs/produktvision.md](docs/produktvision.md).
Sie beschreibt den gewünschten Anwendungsfall und grenzt ihn von historischen
Abstraktionen im Code ab. Beschriebene Ziele sind kein Nachweis bereits
implementierter Funktionen.

Blazingdocs ist ein privates Dokumentenmanagementsystem. Der künftige fachliche
Fokus liegt auf Dokumenten und dem Wiederfinden ihrer Papieroriginale. Die
bestehenden Begriffe `PhysicalObject` und `VirtualObject` stammen aus einer
früheren, breiteren Idee zur Verwaltung beliebiger Gegenstände.

## Orientierung im Repository

- `blazingdocs.slnx`: Solution im Repository-Hauptverzeichnis.
- `01_Execution/`: Web-Host und React-Client (Vite und TypeScript).
- `02_Application/`: Application Services und Contracts.
- `03_Infrastructure/`: Repositories, EF-Core-Persistenz und Dateispeicherung.
- `04_Domain/`: bisheriges Domänenmodell.
- `old/`: frühere Projektstruktur mit eigener Solution; nicht mit der Solution
  im Hauptverzeichnis verwechseln.

Dies ist eine Navigationshilfe, keine Vorgabe, die vorhandene Architektur zu
erhalten. Prüfe für eine konkrete Aufgabe den aktuellen Code und die
Projektdateien. Build, Start und lokale Konfiguration sind in der [README.md](README.md) beschrieben.

## Zusammenarbeit

- Unterscheide aktuellen Implementierungsstand, Produktziele und offene Ideen.
- Die langfristigen Wünsche autorisieren keine umfassende Modernisierung oder
  Umstrukturierung ohne einen entsprechenden Arbeitsauftrag.
- C# als Backend ist die Ausgangsbasis. Datenbank, Suchtechnik und
  Deployment sind noch nicht abschließend für die Weiterentwicklung entschieden.
- Berücksichtige bei Architekturentscheidungen den gewünschten privaten Betrieb
  auf einem Raspberry Pi sowie Dateispeicherung auf NAS oder lokaler Platte.
- Halte diese Datei kurz. Dokumentiere dauerhafte fachliche Erkenntnisse in der
  Produktvision und getroffene Architekturentscheidungen bei Bedarf separat mit
  Begründung. Erzeuge keinen manuell zu pflegenden Katalog aller Klassen.
- Aktualisiere die betroffene Dokumentation, wenn eine Änderung ihre Aussagen
  überholt; leite den tatsächlichen Implementierungsstand aus dem Code ab.
