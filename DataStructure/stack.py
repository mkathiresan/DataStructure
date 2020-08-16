# implementation for stack using list & deque
from collections import deque

class Stack:
    def __init__(self):
        self.stack = []

    def push(self, data):
        self.stack.append(data)

    def pop(self):
        if not self.stack:
            return 'empty stack'
        else:
            return self.stack.pop()

    def show_stack(self):
        return self.stack


class DequeStack:
    def __init__(self):
        self.stack = deque()

    def push(self, data):
        self.stack.append(data)

    def pop(self):
        if not self.stack:
            return 'empty stack'
        else:
            return self.stack.pop()

    def show_stack(self):
        return self.stack

s = DequeStack()
for i in range(1, 11):
    s.push(i)
print(f'stack after push {s.show_stack()}')
for i in range(1, 12):
    print(f'pop from stack : {s.pop()} and the stack : {s.show_stack()}')
