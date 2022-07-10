api.net-prueba
api en .net


Postgres
crear una nueva base de datos de nombre books, y cargar el archivo script base.txt en la consola y correr el script,

.NET
Dentro del proyecto apiBook, proceder a seleccionar proyecto apiBook.Data presionamos click derecho y seleccionar administrar paquete Nuget,
buscamos el paquete Npgsql y lo instalamos.

Configuracion de conexión a BDD
En el proyecto apiBook abrimos el archivo appsettings.json configuramos el acceso a la base de datos, en la variable SqlServeConnection modificaremos los datos de la conexón

Reemplazar el usuario y el password por los de la base de Postgres

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

Para ejecutar el programa apiBook, vamos a la barra de menu y seleccionamos depurar/ iniciar depuración o F5

se desplegara una pagina swagger, con la api y las rutas

