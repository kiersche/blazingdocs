# Produktvision: Blazingdocs

Diese Beschreibung hält die vom Projektinhaber am 8. November 2026 erläuterte
Intention fest. Sie beschreibt das Zielbild, nicht den geprüften Funktionsumfang.

## Zweck und Nutzung

Blazingdocs ist ein Dokumentenmanagementsystem für den persönlichen Privatgebrauch.
Es soll das Ablegen und Wiederfinden von Schriftstücken erleichtern, etwa von
Versicherungsschreiben und Rechnungen für das Auto. Die Erfassung soll so wenig
Aufwand verursachen, dass das System im Alltag tatsächlich genutzt wird.

Der gewünschte Ablauf:

1. Papierdokumente einscannen und die Dateien in Blazingdocs hochladen.
2. Dokumente mit Kategorien, Dokumentarten und Tags erschließen.
3. Bei Bedarf den Aufbewahrungsort des Papieroriginals hinterlegen.
4. Dokumente über Metadaten, kombinierbare Filter und Volltextsuche wiederfinden.
5. Den tatsächlichen Dokumentinhalt direkt in einem eingebetteten Web-Viewer lesen.

Beispiele sind eine chronologische Liste aller Dokumente der Kategorie „Auto“,
eine Einschränkung auf Rechnungen oder ein Tag wie „steuerrelevant“. Welche
Informationen als Kategorie, Dokumentart oder Tag modelliert werden, ist noch
fachlich zu klären. Die Volltextsuche soll OCR-Text gescannter PDFs nutzen; ob OCR
beim Import ausgeführt wird oder bereits vorhandenen Text voraussetzt, ist offen.
Eine schnelle, indexgestützte Suche ist gewünscht; die Technik ist nicht festgelegt.

## Physische Ablage

Aufbewahrungsorte sind frei benennbare und verschachtelbare Container, keine
geografischen Koordinaten. Beispielsweise liegt ein Dokument im „roten Ordner“,
der wiederum im „Arbeitszimmer“ liegt. Diese Hierarchie soll genügen, um das
Papieroriginal zu finden.

Eine frühere Erweiterungsidee war, beliebige physische und virtuelle Gegenstände
zu verwalten. Daher finden sich im Code Begriffe wie `PhysicalObject` und
`VirtualObject`. Die gewünschte Weiterentwicklung soll wieder klar auf Dokumente
ausgerichtet sein. Die allgemeine Inventarverwaltung ist kein Produktziel.
Die Containerhierarchie für Papieroriginale bleibt dagegen fachlich relevant.

## Benutzeroberfläche

Gewünscht ist eine übersichtliche, ansprechende und schnelle Browseroberfläche.
Suche, Erfassung und Dokumentansicht sollen sich nahtlos anfühlen. Ein gut
eingebetteter Dokument-Viewer ist ein zentraler Teil des Zielbilds.

## Technische Ausgangslage und Entwicklungsrichtung

- Das Backend verwendet C# mit .NET 11 und EF Core 11.
- Das Browser-Frontend verwendet React mit Vite und TypeScript. Die erste Dokumentansicht öffnet lokal ausgewählte PDFs.
- Bisher wurde SQL Server mit EF Core vorgesehen. Eine andere Datenbank ist
  möglich; es gibt noch keine neue Auswahlentscheidung.
- Backend-Funktionen und Frontend sollen vervollständigt werden.

Weitere Modernisierungsschritte werden einzeln beauftragt.

## Betrieb und Datensicherung

Ein späterer Betrieb auf einem Raspberry Pi soll möglich sein. Dokumentdateien
sollen auf einem NAS oder einer lokal angeschlossenen Platte liegen können.
Containerbetrieb, eventuell direkt auf einem zukünftigen NAS, ist eine Option;
die konkrete Deployment-Methode bleibt offen.

Regelmäßige Backups sollen sowohl die Metadatenbank als auch den Dateispeicher
abdecken. Bei der späteren Ausarbeitung müssen auch ihre gemeinsame
Wiederherstellung und die Konsistenz zwischen Metadaten und Dateien bedacht werden.

## Spätere Erweiterungsideen

- Eine lokale KI könnte Metadaten und OCR-Texte für die Arbeit mit den Dokumenten
  nutzen. Aufgaben, Modell und technische Umsetzung sind noch offen.
- Auswertungen könnten beispielsweise den Zeitverlauf der Rechnungsbeträge für
  die Kategorie „Auto“ über die letzten drei Jahre als Diagramm darstellen.
  Dafür benötigte strukturierte Daten, ihre Erfassung und fachliche Regeln sind
  noch zu bestimmen.

Diese Ideen erweitern das Zielbild; sie sind keine Voraussetzung dafür, zuerst
einen nützlichen Ablauf vom Import bis zum Wiederfinden umzusetzen.
