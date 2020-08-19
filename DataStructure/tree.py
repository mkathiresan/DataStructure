#implementation for tree

class Tree:
    def __init__(self, data):
        self.data = data
        self.child = []
        self.parent = None

    def add_child(self, child):
        self.child.append(child)
        child.parent = self

    def display_tree(self):
        print(self.data)
        for i in self.child:
            print('    ' + i.data)


root = Tree('electronics')

mobile = Tree('mobile')
computer = Tree('computer')
camera = Tree('camera')

root.add_child(mobile)
root.add_child(computer)
root.add_child(camera)

root.display_tree()
