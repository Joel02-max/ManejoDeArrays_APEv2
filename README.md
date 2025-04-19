Sistema de Resolción de ecuaciones - WinForms (.NET Framework)

Este proyecto es una aplicación de escritorio construida con Windows Forms (.NET Framework), que permite resolver distintos ejercicios relacionados con álgebra lineal y análisis numérico, tales como:
- Cálculo de determinantes (Ejercicio 1)
- Resolución de ecuaciones lineales (Ejercicio 2)
- Descomposición QR (Ejercicio 3)
- Método de Jacobi (Ejercicio 4)

 Tecnologías utilizadas
- .NET Framework (WinForms)
- C#
- Arquitectura en capas (Presentación y Lógica de Negocio)

Arquitectura del proyecto

Presentacion (Proyecto WinForms)

- FormMenu.cs (menú principal)
- FormEjercicio1.cs
- FormEjercicio2.cs
- FormEjercicio3.cs
- FormEjercicio4.cs
- LogicaNegocio (Capa de lógica)
- MatrizNegocio.cs

Instrucciones de uso
1. Clonar el repositorio
2. Abrir en Visual Studio
3. Ejecutar la aplicación

Funcionalidades 
FormMenu
* Menú principal del sistema.
* Contiene botones para acceder a cada uno de los ejercicios.
* Permite abrir la documentación del proyecto en PDF.
* Opción para cerrar la aplicación.
* Implementa un método genérico OpenForm(Type) para abrir formularios dinámicamente y ocultar el menú mientras se usan.

*FormEjercicio1 (Determinante de una matriz)

- Permite al usuario ingresar una matriz cuadrada de orden n.
- Calcula y muestra el determinante de la matriz.
- Verificación automática del orden de la matriz para validar la operación.
- Ideal para reforzar conceptos de álgebra lineal.

FormEjercicio2  (Resolución de Sistemas de Ecuaciones)

- Permite ingresar un sistema de ecuaciones lineales.
- Resuelve el sistema utilizando métodos numéricos (Eliminación Gaussiana o Gauss-Jordan).
- Muestra paso a paso la solución y el resultado final.
- Útil para estudiantes que estudian Álgebra Lineal o Métodos Numéricos.

 FormEjercicio3 (Descomposición QR)
 
- Aplica la descomposición QR a una matriz para resolver sistemas de ecuaciones.
- Separa la matriz en sus componentes ortogonales (Q) y triangulares superiores (R).
- Permite resolver ecuaciones del tipo Ax = b con mayor estabilidad numérica.
- Visualiza las matrices Q, R y el vector x resultado.

FormEjercicio4 (Método de Jacobi)

- Permite resolver sistemas lineales iterativamente usando el método de Jacobi.
- Configuración del número máximo de iteraciones y tolerancia de error.
- Ideal para sistemas grandes o dispersos donde los métodos directos no son eficientes.
Muestra iteración por iteración el progreso hacia la solución.
