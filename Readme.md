# Story Mania Hör-Box Tools

Die [Story Mania Hör-Box](https://storymania.migros.ch/de/hoerspiele/hoer-box/) wurde von der Migros im Herbst 2017 im Rahmen einer Promoaktion verkauft.

## Funktionsweise

- Die Hör-Box wird am Computer mit Audiodateien im proprietären SMP Format befüllt. 
- Die Datein sind müssen im Format M01.smp - M31.smp benannt sein.
- M01.smp - M11.smp sind für die Migros Höhrspiele reserviert und mit den verkauften Figuren verknüpft. Falls man auf diese Höhrspiele verzichten kann, können sie überschrieben werden.
- M12.smp ist der Figur "Lulu" zugeordnet, welche von Migros für eigene Hörspiele vorgeshen ist.
- Um die Dateien M13.smp bis M31.smp benutzen zu können, müssen leere RFID Tags entsprechend beschrieben werden.

## Konvertierung
Grundsätzlich kann die Hör-Box MP3 Dateien abspielen. Offenbar sollte aber verhindert werden, dass jeder einfach seine eigenen Dateien abspielen kann. Deshalb müssen die Datein XOR mit dem Buchstaben "f" verschlüsselt und die Endung von MP3 auf SMP geändert werden.

## Konverter 

### Windows (.NET 4.0)

- Source Code: [/HoerBoxEncoder/Windows/HörBoxEncode](/HoerBoxEncoder/Windows/HörBoxEncode)
- Releases: [Releases/Windows](Releases/Windows)
