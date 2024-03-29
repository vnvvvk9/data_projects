public interface ICache{
    string get(string key);
    void set(string key, string value);
    void remove(string key);
}

public class RedisCache:ICache{
    private readonly IDatabase _redisclient
    public RedisCache(IDatabase redisclient){
        _redisclient=redisclient;
    }
    public string get(string key){
        _redisclient.StringGet(key);
    }

    public void set(string key, string value){
        _redisclient.StringSet(key, value);
    }
    public void remove(string key) {
        _redisclient.KeyDelete(key);
    }

}
public class InMemoryCache: ICache{
    private readonly Dictionary<string,string> _cache= new Dictionary<string, string>();
    public string get(string key){
        if(_dict.ContainsKey(key)) return _dict[key];
        return "";
    }
    public void set(string key, string val){
        _cache.Add(key,value);
    }
    public void remove(string key){
        _cache.Remove(key);
    }
}
public class CacheManager{
    private readonly ICache _cache;

    public CacheManager(ICache cache){
        _cache= cache;
    }

    public string get(string key){
        return _cache.get(key);
    }

    public void set(string key, string value){
        _cache.get(key,value);
    }
    public void remove(string gkey){
        _cache.remove(key);
    }
}


public class program{

    public static void Main(string[] args){
        var inMemCach =new InMemoryCache()
        var cacheManager= new CacheManager(inMemCach);
        var redisCache= new RedisCache();

        cacheManager= new CacheManager(redisCache);
        

    }
}