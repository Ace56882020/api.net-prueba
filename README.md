api.net-prueba
api en .net

SE CONFIGURO POSTGRES COMO MANEJADOR DE BASE DE DATOS,

se adjunta el script base.txt, para poder cargar el modelo, dentro del proyecto 

en el proyecto de .net (apiBook) en el archivo appsettings.json configuramos el acceso a la base de datos, con el usuario y contrasña

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "SqlServeConnection": "Server=127.0.0.1;Port=5432;Database=books;User Id=postgres;password=Ace5688"
  }
  
}

el proyecto se conforma de la api rest principal apiBook
una capa apiBook.Data que gestiona las consultas
y el modelo apiBook.Data

se debe instalar Npgsql del paquete de Nuget en el proyecto apiBook.Data, para poder tener el acceso a la base de datos, en el proyecto 
se debe dar un clic derecho /administrar paquetes nuget
y en la ventana izquierda en la pestaña examinar buscamos el paquete a instalar
y ya podemos ejecutar el proyecto, el cual nos llevara a la pagina de la api, donde se puede realizar las consultas o peticiones corresponientes

