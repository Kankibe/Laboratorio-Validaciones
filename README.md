# Laboratorio de Validaciones

Fecha: 13/09/2026

## Contenido del Repositorio

Este laboratorio aplica validación de datos y control de errores en dos ejercicios de C#: un juego de Craps que utiliza enumeraciones para controlar el estado de la partida, y un formulario Windows Forms con un DataGridView que valida los datos de un empleado antes de agregarlos a la lista (campos vacíos, formato de correo y formato numérico del salario).

## Tecnologías Utilizadas

- C# / .NET
- Windows Forms
- Visual Studio 2026

## Capturas de Pantalla y Problemas

- **Caso Juego de Craps:** simulación del juego de dados usando una enumeración para el valor de los dados y otra para el estado de la partida (continúa, gana, pierde). El método `LanzarDados()` genera los dos valores aleatorios y `Jugar()` controla la lógica de victoria o derrota según las reglas del juego.
<img width="370" height="139" alt="image" src="https://github.com/user-attachments/assets/76d08521-a290-4576-a421-9f4abe5332db" />

- **Ejemplo Grid:** formulario con un DataGridView que captura empleados (ID, nombres, apellidos, correo, fecha de nacimiento, salario). Antes de agregar el registro, valida que ningún campo esté vacío, que el correo tenga formato válido y que el salario sea un valor numérico, mostrando el error con un ErrorProvider junto al campo correspondiente.
  <img width="751" height="649" alt="image" src="https://github.com/user-attachments/assets/1646cfa7-56d9-41ea-9ed8-887eaf7531fc" />
  
## Estructura de Carpetas o Directorios
```
Laboratorio Validaciones/
├── CasoJuegoCraps/
│   ├── CasoJuegoCraps.csproj
│   ├── CasoJuegoCraps.slnx
│   ├── Class1.cs           # Clase Craps: logica del juego
│   └── Program.cs          # Punto de entrada
│
└── EjemploGrid_/
    ├── EjemploGrid_.csproj
    ├── EjemploGrid_.slnx
    ├── App.config
    ├── Program.cs           # Punto de entrada
    ├── Form1.cs             # Formulario y validaciones
    ├── Form1.Designer.cs
    ├── Form1.resx
    ├── Class1.cs            # Clase Persona
    ├── Class2.cs            # Clase Utilidades (validacion de correo)
    └── Properties/
        ├── AssemblyInfo.cs
        ├── Resources.Designer.cs
        ├── Resources.resx
        ├── Settings.Designer.cs
        └── Settings.settings
```

## Autor y Contexto

- Nombre: Kankibe González
- Institución: Universidad Tecnológica de Panamá (UTP)
- Fecha de Realización: 13/09/2026
