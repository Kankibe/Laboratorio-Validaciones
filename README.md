# Laboratorio de Validaciones

Fecha: 13/09/2026

## Contenido del Repositorio

Este laboratorio aplica validación de datos y control de errores en dos ejercicios de C#: un juego de Craps que utiliza enumeraciones para controlar el estado de la partida, y un formulario Windows Forms con un DataGridView que valida los datos de un empleado antes de agregarlos a la lista (campos vacíos, formato de correo y formato numérico del salario).

Además, el repositorio incluye un tercer proyecto, WinFormsApp1 (MDI), que muestra cómo trabajar con una aplicación de interfaz de múltiples documentos en Windows Forms: un formulario contenedor con una barra de herramientas que abre una ventana hija sin duplicarla.

## Tecnologías Utilizadas

- C# / .NET
- Windows Forms
- Visual Studio 2026

## Capturas de Pantalla y Problemas

- **Caso Juego de Craps:** simulación del juego de dados usando una enumeración para el valor de los dados y otra para el estado de la partida (continúa, gana, pierde). El método `LanzarDados()` genera los dos valores aleatorios y `Jugar()` controla la lógica de victoria o derrota según las reglas del juego.
<img width="370" height="139" alt="image" src="https://github.com/user-attachments/assets/76d08521-a290-4576-a421-9f4abe5332db" />

- **Ejemplo Grid:** formulario con un DataGridView que captura empleados (ID, nombres, apellidos, correo, fecha de nacimiento, salario). Antes de agregar el registro, valida que ningún campo esté vacío, que el correo tenga formato válido y que el salario sea un valor numérico, mostrando el error con un ErrorProvider junto al campo correspondiente.
  <img width="751" height="649" alt="image" src="https://github.com/user-attachments/assets/1646cfa7-56d9-41ea-9ed8-887eaf7531fc" />
-**Ejemplo MDI (WinFormsApp1):** aplicación de interfaz de múltiples documentos (MDI). Form1 es el formulario contenedor (IsMdiContainer = true) y tiene un ToolStrip con el botón tsbActivar. Al hacer clic, se abre la ventana hija frmVentanaTexto asignándole MdiParent = this. Antes de crearla, se revisa con Application.OpenForms.OfType<frmVentanaTexto>() si ya hay una abierta; si existe, solo se trae al frente con BringToFront() y Focus(), así nunca se abren ventanas duplicadas.
  
  <img width="703" height="546" alt="image" src="https://github.com/user-attachments/assets/6f39104d-4e3b-4a70-88fc-bb3dc4800869" />

  
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

WinFormsApp1/
├── WinFormsApp1.slnx
└── WinFormsApp1/
    ├── WinFormsApp1.csproj
    ├── Program.cs           # Punto de entrada (abre Form1)
    ├── Form1.cs             # Formulario MDI contenedor y apertura de la ventana hija
    ├── Form1.Designer.cs
    ├── Form1.resx
    ├── Form2.cs             # Ventana hija frmVentanaTexto
    ├── Form2.Designer.cs
    └── Form2.resx
```

## Autor y Contexto

- Nombre: Kankibe González
- Institución: Universidad Tecnológica de Panamá (UTP)
- Fecha de Realización: 13/09/2026
