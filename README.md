# TP Visual Studio 1 - IFTS Nº 24

Este proyecto fue desarrollado como parte del primer trabajo práctico de la materia **Técnicas de Programación**, en el Instituto de Formación Técnica Superior N.º 24. El objetivo principal es aprender y practicar los fundamentos del lenguaje **C#**, utilizando aplicaciones de consola desarrolladas en .NET.

El repositorio incluye tres subproyectos independientes:

- **Variables**
- **Constantes**
- **Operadores**

---

## 📁 Estructura del Proyecto

- `Variables/`: Demostración del uso de variables y tipos de datos básicos.
- `Constantes/`: Declaración y uso de constantes.
- `Operadores/`: Uso de operadores aritméticos, incremento y relaciones.

---

## 🧠 Contenidos y Conceptos

### Variables

Este módulo demuestra cómo declarar y utilizar distintos tipos de variables:

- `bool` (Booleano)
- `int` (Entero)
- `double` (Decimal)
- `string` (Texto)
- `DateTime` (Fecha y hora actual)

También se imprimen propiedades útiles del tipo `DateTime`, como:

- `.Date`, `.Day`, `.DayOfWeek`, `.Month`, `.Year`
- `.TimeOfDay`, `.Hour`, `.Minute`, `.Second`, `.Millisecond`
- `.Ticks`, `.Kind`

### Constantes

Ejemplo de uso de la palabra clave `const` para declarar constantes en C#:

```csharp
const string Empresa = "Acme";
const byte HorasLaborales = 40;
```

Las constantes son valores inmutables que se definen en tiempo de compilación.

### Operadores

Demostración de operadores aritméticos:

- `+`, `-`, `*`, `/`, `%`

Y operadores de incremento:

- `var++`
- `++var`
- `var += n`

Se incluye una introducción al uso de operadores relacionales.

---

## ▶️ Cómo ejecutar el proyecto

1. Cloná el repositorio:

```bash
git clone https://github.com/mati-d-s/Tp-Csharp-IFTS24.git
cd Tp-Csharp-IFTS24
```

2. Ingresá a cada subcarpeta y ejecutá con:

```bash
cd Variables
dotnet run

cd ../Constantes
dotnet run

cd ../Operadores
dotnet run
```

> Asegurate de tener instalado [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

---

## 💻 Requisitos

- .NET SDK 8.0 o superior
- Visual Studio 2022 o Visual Studio Code (con la extensión C#)
- Windows, Linux o macOS

---

## 📷 Ejemplo de salida esperada

```
Variables y tipos de datos

Boolean = True
Int = 2147483647
Double = 13.78
String = Abcdefghijklmnopqrstwxyz 1234567890 @ ' ¡ ! ? ¿ $ % & # / \ ( )

DateTime = 19/06/2025 21:00:00
DateTime.DayOfWeek = Thursday
DateTime.Hour = 21
DateTime.Minute = 00
DateTime.Millisecond = 123
...
```

---

## 👨‍💻 Autor

**Matías Soto**  
Estudiante del IFTS Nº 24  
GitHub: [@mati-d-s](https://github.com/mati-d-s)

---

## 📄 Licencia

Este proyecto se publica con fines educativos y puede ser reutilizado o adaptado libremente por otros estudiantes o docentes.
