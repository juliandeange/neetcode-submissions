public class LRUCache {

    Dictionary<int, int> cache;
    LinkedList<int> recent;
    int size;

    public LRUCache(int capacity) {
        cache = new Dictionary<int, int>();
        recent = new LinkedList<int>();
        size = capacity;
    }
    
    public int Get(int key) {

        if (cache.ContainsKey(key)) {
            // update its used
            recent.Remove(key);
            recent.AddFirst(key);

            return cache[key];
        }
        else
            return -1;
        
    }
    
    public void Put(int key, int value) {

        if (!cache.ContainsKey(key) && cache.Count() < size) {
            // add it to the cache
            cache.Add(key, value);
            recent.AddFirst(key);

        }
        else if (cache.ContainsKey(key)){
            // update the cache
            cache[key] = value;

            // update its used
            recent.Remove(key);
            recent.AddFirst(key);
        }
        else {
            // remove the LRU
            int lastKey = recent.Last.Value;
            recent.RemoveLast();
            cache.Remove(lastKey);

            cache.Add(key, value);
            recent.AddFirst(key);

        }
        
    }
}
