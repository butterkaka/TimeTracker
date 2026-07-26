# TimeTracker

## Beskrivning
TimeTracker är en Windows Forms-applikation för tidtagning och resultatregistrering vid tävlingar. Programmet används för att starta en tävlingstimer, registrera målgångar och koppla resultat till deltagare via startnummer.

## Funktioner
- Importera deltagare från Excel (`.xlsx`) med formatet `Startnummer | Namn | Klubb | Klass`.
- Starta, stoppa, nollställ och justera tävlingstid.
- Registrera resultat manuellt eller via deltagarlistans målknapp.
- Koppla resultat till deltagare via startnummer.
- Varnar när ett startnummer redan finns i resultatlistan och kan flytta deltagaren vid behov.
- Markerar deltagare som redan finns i resultatlistan med bakgrundsfärg.
- Filtrera deltagarlistan för att visa alla eller endast deltagare som inte gått i mål.
- Visa tidtagningen i ett separat fönster.
- Spara och öppna tävlingsdata som JSON.
- Exportera resultat till Excel (`.xlsx`).
- Resultattider sparas med hundradelar.

## Tekniska detaljer
- Byggd med **.NET 10** och **C#**.
- Desktopapplikation med **Windows Forms**.
- Använder **ClosedXML** för Excel-import och Excel-export.
- Sparar tävlingar som JSON.

## Filstruktur
- `MainForm.cs` - huvudfönster för tidtagning, deltagare och resultat.
- `Models/` - modeller för tävling, deltagare och resultat.
- `Services/FileService.cs` - import, export, spara och öppna filer.
- `TimeTrackerStopWatch.cs` - stoppklocka med stöd för startoffset.
- `StopWatchForm.cs` - separat visningsfönster för tidtagning.
- `SetTimerForm.cs` - formulär för manuell justering av tid.
- `Assets/` - ikoner och bilder.

## Krav
- Windows.
- .NET 10 Runtime eller SDK.

## Användning
1. Starta programmet.
2. Importera deltagare från Excel eller öppna en sparad tävling.
3. Starta timern.
4. Lägg till målgångar med resultatknappen, mellanslagstangenten eller deltagarlistans målknapp.
5. Fyll i eller kontrollera startnummer i resultatlistan.
6. Spara tävlingen eller exportera resultatet till Excel.

## Säkerhet vid tävling
- Resultat via deltagarlistan registreras bara när timern är igång.
- Samma deltagare kan inte registreras flera gånger via deltagarlistans målknapp.
- Filfel vid öppning och export visas som felmeddelande istället för att krascha programmet.

