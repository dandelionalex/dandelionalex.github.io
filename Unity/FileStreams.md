#File streams

FileStream fileObj = new FileStream(file Name/Path, FileMode.field, FileAccess.field, FileShare.field);


using(FileStream fs = File.Create("filename"))
{
    BinaryFormatter binf = new BinaryFormatter();
    binf.Serialize(fs, saveData);
}