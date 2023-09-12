# Inyección de dependencias en .NET

## Introducción

La inyección de dependencias (DI) es un patrón de diseño de software que permite que un objeto dependa de otro objeto sin tener que conocer su implementación. Esto se logra inyectando la dependencia en el objeto que la necesita.

La inyección de dependencias es una técnica poderosa que puede ayudar a mejorar la calidad del código de varias maneras:

* **Reduce el acoplamiento entre objetos:** Al inyectar dependencias, eliminamos la necesidad de que los objetos se conozcan entre sí. Esto hace que el código sea más flexible y fácil de mantener.
* **Mejora la testabilidad:** La inyección de dependencias facilita la creación de pruebas unitarias para objetos. Esto se debe a que podemos reemplazar las dependencias con mocks o stubs, lo que nos permite aislar el objeto que estamos probando.
* **Permite la sustitución de implementaciones:** La inyección de dependencias nos permite cambiar la implementación de una dependencia sin tener que modificar el código que la utiliza. Esto nos da más flexibilidad para adaptar nuestra aplicación a cambios futuros.

En este proyecto se estara mostrando ejemplos en consola como implementar inversión de dependencias, inyección de depencias en .NET