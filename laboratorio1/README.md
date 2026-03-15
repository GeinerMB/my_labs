# Laboratorio 1 - Proyecto .NET (Guia Base)

Este README es un borrador para documentar como crear un proyecto de .NET desde cero para el laboratorio de la universidad: instalacion del SDK, creacion de la solucion, creacion del proyecto y vinculacion entre ambos.

## 1. Instalacion de .NET SDK (Linux Ubuntu/Debian)

Si ya tienes .NET instalado, puedes saltar esta seccion.

### 1.1 Instalar SDK

```bash
sudo apt update
sudo apt install -y dotnet-sdk-8.0
```

### 1.2 Verificar instalacion

```bash
dotnet --version
```

## 2. Crear carpeta del laboratorio

```bash
mkdir laboratorio1
cd laboratorio1
```

## 3. Crear la solucion (.sln)

```bash
dotnet new sln -n laboratorio1
```

Esto genera el archivo:

- laboratorio1.sln

## 4. Crear el proyecto ASP.NET Core MVC

```bash
dotnet new mvc -n Laboratorio1_C25063
```

Esto crea una carpeta con el proyecto y su archivo .csproj.

## 5. Conectar el proyecto a la solucion

```bash
dotnet sln laboratorio1.sln add Laboratorio1_C25063/Laboratorio1_C25063.csproj
```

Con esto, la solucion queda enlazada con el proyecto del laboratorio.

## 6. Restaurar paquetes y compilar

Esto no va a borrar codigo que hayas escrito, es parte del proceso de compilacion del proyecto

```bash
dotnet restore
dotnet build
```

## 7. Ejecutar el proyecto

Puedes ejecutarlo desde la raiz de la solucion indicando el proyecto:

```bash
dotnet run --project Laboratorio1_C25063
```

## 8. Estructura esperada

```text
laboratorio1/
|- laboratorio1.sln
|- Laboratorio1_C25063/
	|- Laboratorio1_C25063.csproj
	|- Program.cs
	|- Controllers/
	|- Models/
	|- Views/
	|- wwwroot/
```
