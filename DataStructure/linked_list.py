# Implementation for linked list

# Node class
class Node:
    def __init__(self, data=None, next=None):
        self.data = data
        self.next = next


class LinkedList:
    def __init__(self):
        self.head = None

    def insert_first(self, data):
        node = Node(data, self.head)
        self.head = node

    def add_node(self, data):
        if self.head is None:
            self.head = Node(data, None)
            return

        iterate = self.head
        while iterate.next:
            iterate = iterate.next

        iterate.next = Node(data, None)

    def insert_after(self, index, data):
        if self.head is None:
            print('Linked list is empty, adding as head node')
            self.insert_first(data)
            return
        if index <= 0:
            print('index not valid')
            return
        node_len = self.node_length()
        insert_index = 1
        iterate = self.head
        insert_node = Node(data, None)
        while iterate:
            if index == insert_index:
                insert_node.next = iterate.next
                iterate.next = insert_node
                break
            iterate = iterate.next
            insert_index += 1

    def add_nodes(self, list_data):
        for data in list_data:
            self.add_node(data)

    def print_node(self):
        if self.head is None:
            print('Linked list is empty')
            return
        iterate = self.head
        list_srt = ''
        while iterate:
            list_srt += str(iterate.data) + ' ==> '
            iterate = iterate.next
        print(list_srt)

    def node_length(self):
        if self.head is None:
            return 0
        iterate = self.head
        list_count = 0
        while iterate:
            list_count += 1
            iterate = iterate.next
        return list_count

    def delete_node(self, index):
        if self.head is None:
            print('Linked list is empty')
            return
        node_len = self.node_length()
        if 0 <= index > node_len:
            print('Delete index not valid')
            return
        delete_index = 1
        # delete head node
        if index == 1:
            self.head = self.head.next
        # delete tail node
        elif index == node_len:
            iterate = self.head
            while iterate:
                if (delete_index + 1) == index:
                    iterate.next = None
                    break
                iterate = iterate.next
                delete_index += 1
        # delete the index node
        else:
            iterate = self.head
            while iterate:
                if (delete_index + 1) == index:
                    before_node = iterate
                elif delete_index == index:
                    before_node.next = iterate.next
                    break
                iterate = iterate.next
                delete_index += 1

        iterate = self.head
        while iterate:
            iterate = iterate.next


if __name__ == '__main__':
    linked_list = LinkedList()
    linked_list.insert_first(20)
    linked_list.insert_first(10)
    linked_list.add_node(30)
    linked_list.add_nodes([40, 50, 60, 70, 80, 90])
    linked_list.print_node()
    print(f'length of the list : {linked_list.node_length()}')
    linked_list.delete_node(1)
    print('print after deleting head node')
    linked_list.print_node()
    linked_list.insert_first(10)
    linked_list.delete_node(linked_list.node_length())
    print('print after deleting tail node')
    linked_list.print_node()
    linked_list.delete_node(3)
    print('print after deleting 3rd node')
    linked_list.print_node()
    linked_list.insert_after(1, 5)
    print('print after insert after head node')
    linked_list.print_node()
    linked_list.insert_after(3, 45)
    print('print after insert after 3rd node')
    linked_list.print_node()
