# Image worker

Provides the way to resize images and save them to defined directory with new Guid name.

## How to use

#### Create an instance of FactoryImage like:

```cs
FactoryImage factory = new FactoryImage();
```

#### From there you can get desired service:
```cs
var service = factory.GetWorker(WorkerType.Resize);
```
- This one will crate ResizeImageWorker that derives from ```IWorkerImage``` interface.

#### Now you can use resize service like:
```cs
string path = await service.SaveAndModifyAsync(formFile, width, height, dir);
```
- This returns the path to the file in case you want to store it to database.

## ASP.NET Core

#### You can register factory to ```ConfigureServices``` in Startup.cs like:
```cs
services.RegisterImageFactory();
```

#### And then instead of using ```FactoryImage``` directly you can use interface implementation like
```cs
class SomeClass
{
     private readonly IFactoryImage _factory;

     public SomeClass(IFactoryImage factory)
     {
          _factory = factory;
     }
}
```

## Exceptions

#### Exceptions you can expect are:

```cs
InvalidDimensionsException
```
- Provided that you placed width and height of an image to 0 or less
```cs
InvalidExtensionTypeException
``` 
- provided that you placed an image that is not supported (anything that is not jpg, jpeg, png is not supported for now)

## Supported actions
- Resize