Opto por hacer un Readme a un "IA.MD", para más orden.

#### ***Versión en español***
# Registro de Uso de la Inteligencia Artificial.
**Herramienta** Github Copilot
**Propósito:** Generar y Documentar un .gitignore para Unity 6.
**Validaciones**
- Library, Temp, Logs sean ignorados.
- Assets, Packages, ProjectSettings y .meta permanezcan versionables.
**Decisión:** Tras leer todo un poco el resumen que me otorgó la IA, acepte todo sin realizar cambios. Principalmente porque no vi que afectara a ningun archivo que se me solicito no ignorar. (O eso creo...)

En la parte del movimiento, no use IA generativa hasta cierto punto, note un cambió y lo ajuste por mi cuenta (Codigo Spagetti), volviendo de una hila de IF a un Switch... Lo cual descarte al ver que no permitía que se produciera el movimiento en Diagonal. 

Valió la pena el intento.

***Herramienta*** Github Copilot
***Propuse*** Debug
***Validaciones***
- No solicito añadir nada, a excepción de la linea 11-12 de MovementScript.cs. C: todo parece ir OK

***Herramienta*** Github Copilot
***Proposito*** Revisar el GameManager.Cs
- Solicito añadir una función que no termine de entender, preferí no añadirla.


***Herramienta*** Github Copilot
***Proposito*** Solución de Problemás con la Camara (El tuto no funco del todo)
***Validaciones***
- Al inicio generaba complicaciones, provocando que el saltó se bugueara. Más tras un debuggeo manual (Se habia roto el Cilinder de Player) se soluciono. No hubo necesidad de quitar nada. A su par, otro ploblema que se generaba era el que no permitía reiniciar el Nivel por un bloqueo de Cursor (cosa que se desactivó)