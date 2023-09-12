# Inyecci�n de dependencias en .NET

## Introducci�n

La inyecci�n de dependencias (DI) es un patr�n de dise�o de software que permite que un objeto dependa de otro objeto sin tener que conocer su implementaci�n. Esto se logra inyectando la dependencia en el objeto que la necesita.

La inyecci�n de dependencias es una t�cnica poderosa que puede ayudar a mejorar la calidad del c�digo de varias maneras:

* **Reduce el acoplamiento entre objetos:** Al inyectar dependencias, eliminamos la necesidad de que los objetos se conozcan entre s�. Esto hace que el c�digo sea m�s flexible y f�cil de mantener.
* **Mejora la testabilidad:** La inyecci�n de dependencias facilita la creaci�n de pruebas unitarias para objetos. Esto se debe a que podemos reemplazar las dependencias con mocks o stubs, lo que nos permite aislar el objeto que estamos probando.
* **Permite la sustituci�n de implementaciones:** La inyecci�n de dependencias nos permite cambiar la implementaci�n de una dependencia sin tener que modificar el c�digo que la utiliza. Esto nos da m�s flexibilidad para adaptar nuestra aplicaci�n a cambios futuros.

En este proyecto se estara mostrando ejemplos en consola como implementar inversi�n de dependencias, inyecci�n de depencias en .NET