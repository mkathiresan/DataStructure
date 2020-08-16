# implementation for queue using list & deque
from collections import deque


class Queue:
    def __init__(self):
        self.queue = []

    def push(self, data):
        self.queue.insert(0, data)

    def pop(self):
        if not self.queue:
            return 'empty queue'
        else:
            return self.queue.pop()

    def show_queue(self):
        return self.queue


class DequeQueue:
    def __init__(self):
        self.queue = deque()

    def push(self, data):
        self.queue.append(data)

    def pop(self):
        if not self.queue:
            return 'empty queue'
        else:
            return self.queue.popleft()

    def show_queue(self):
        return self.queue


s = Queue()
for i in range(1, 11):
    s.push(i)
print(f'queue after push {s.show_queue()}')
for i in range(1, 12):
    print(f'pop from queue : {s.pop()} and the queue : {s.show_queue()}')
