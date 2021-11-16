# Builder
Es un patr�n creacional. [Link descripci�n](https://www.tutorialspoint.com/design_pattern/builder_pattern.htm)

El patr�n builder se encarga de instanciar nuevos objetos complejos compuestos de varias dependencias que deb�n ser creadas para obtener un objeto completo.

## Diagrama de clases
![UML](builder.jpg)

## SOLID

* Single responsibility
 
La �nica responsabilidad del builder es construir objetos completos, por ese lado esta cubierta la responabilidad, pero el builder debe ser modificado si cambia la implementaci�n de algunas de las dependencias del objeto complejo. Lo que romper�a con el principio.

* Open/Closed principle

Si necesitamos crear nuevos objetos con crear un nuevo builder alcanza, por lo que este punto estar�a Ok.
 
* Liskov substitution principle
 
Cualquie builder puede sustituir al builder abstracto, ademas si siempre esperamos una interfaz los objetos creados por los diferentes builders del mismo tipo de objetos tambi�n ser�n sustituibles.

* Interface segregation

Poner todos los m�todos de creaci�n de dependencia en la clase builder abstracta desaf�a este principio pero con un poco de cuidado pueden desarrollarse builders que segreguen la interfaz correctamente (utilizando una interfaz builder en lugar de clase abstracta con template method como en este ejemplo). 

* Dependency inversion

Tanto los builders como el objeto a crear son referenciados siempre por sus superclases por lo que la inversi�n de dependencia se cumple.
