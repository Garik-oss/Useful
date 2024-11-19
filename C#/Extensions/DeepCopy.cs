public static class ExtObject
{ 
    public static T DeepCopy<T>(this T objectToCopy)
    {
        var jsonString = JsonSerializer.Serialize(objectToCopy);

        return JsonSerializer.Deserialize<T>(jsonString)!;
    }

    //obsolete
    public static T DeepCopyBinary<T>(this T objectToCopy) 
    {
         MemoryStream memoryStream = new MemoryStream(); 
         BinaryFormatter binaryFormatter = new BinaryFormatter(); 
         binaryFormatter.Serialize(memoryStream, objectToCopy); 

  
         memoryStream.Position = 0; 
         T returnValue = (T)binaryFormatter.Deserialize(memoryStream); 

  
         memoryStream.Close(); 
         memoryStream.Dispose(); 

  
         return returnValue; 
    }
} 
