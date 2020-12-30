# Image worker

Provides the way to resize images and save them to defined directory with new Guid name.

## How to use

#### Create an instance of WorkerFactory like:

```cs
WorkerFactory factory = new WorkerFactory();
```

#### From there you can get desired service:
```cs
var service = factory.GetWorker(WorkerType.Resize);
```
- This one will crate ResizeImageWorker that derives from ```IImageWorker``` interface.

#### Now you can use resize service like:
```cs
string path = await service.Save(formFile, width, height, dir);
```
- This returns the path to the file in case you want to store it to database.

## ASP.NET Core

#### You can register factory to ```ConfigureServices``` in Startup.cs like:
```cs
services.RegisterImageWorker();
```

#### And then instead of using ```WorkerFactory``` directly you can use interface implementation like
```cs
class SomeClass
{
     private readonly IWorkerImageFactory _factory;

     public SomeClass(IWorkerImageFactory factory)
     {
          _factory = factory;
     }
}
```