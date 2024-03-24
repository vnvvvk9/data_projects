public interface ICache{
    T Get<T> (string key);
    void Set(string key, T value, TimeSpan expiry);
    bool TryGewt(string key);
    coid Remove(string gkey);
}

public SimpleCache:ICache{
    private readonly Dictionary<string, CacheEntry> _dict;

    public SimpleCache(){
        _dict= new Dictionary<string, CacheEntry>();
    }

    public Get(string key){
        var cur= GetEntry(key);
    }
}

public class CacheEntry{
    publis string value{get;}

}