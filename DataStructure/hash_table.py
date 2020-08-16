# implementation for hash table

class Hash_Table:

    def __init__(self, size=10):
        self.max_len = size
        self.hash_array = [None for _ in range(0, self.max_len)]

    def get_hash(self, key):
        hash_key = 0
        for i in key:
            hash_key += ord(i)
        return hash_key % self.max_len

    def __setitem__(self, key, value):
        hash_key = self.get_hash(key)
        self.hash_array[hash_key] = value

    def __getitem__(self, key):
        hash_key = self.get_hash(key)
        return self.hash_array[hash_key]


t = Hash_Table(5)
t['monday'] = 100
print(t['monday'])
print(t.hash_array)