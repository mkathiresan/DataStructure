# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def __init__(self):
        self.head = None

    def add_node(self, data):
        if self.head is None:
            self.head = ListNode(data, None)
            return
        iterate = self.head
        while iterate.next:
            iterate = iterate.next

        iterate.next = ListNode(data, None)

    def print_node(self):
        if self.head is None:
            print('Linked list is empty')
            return
        iterate = self.head
        list_srt = ''
        while iterate:
            list_srt += str(iterate.val) + ' ==> '
            iterate = iterate.next
        print(list_srt)

    def mergeTwoLists(self, l1: ListNode, l2: ListNode) -> ListNode:
        while l1 or l2:
            if not l1:
                self.add_node(l2.val)
                l2 = l2.next
            elif not l2:
                self.add_node(l1.val)
                l1 = l1.next
            elif l1.val <= l2.val:
                self.add_node(l1.val)
                l1 = l1.next
            else:
                self.add_node(l2.val)
                l2 = l2.next
        return self.head

# better solution
    def bettersolution(self, l1: ListNode, l2: ListNode):
        if not l1:
            return l2
        if not l2:
            return l1
        if l1.val < l2.val:
            node_head = l1
            node_teal = self.bettersolution(l1.next, l2)
        else:
            node_head = l2
            node_tail = self.bettersolution(l1, l2.next)
            node_head.next = node_tail
            return node_head

l1 = ListNode(1)
l2 = ListNode(1)
s = Solution()
s.mergeTwoLists(l1, l2)
print(s.print_node())