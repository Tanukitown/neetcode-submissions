# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:    
    def mergeKLists(self, lists: List[Optional[ListNode]]) -> Optional[ListNode]:
        result = ListNode()

        options = []
        for nodeList in lists:
            cur = nodeList
            while cur:
                options.append(cur.val)
                cur = cur.next
        options.sort()
        cur = result
        for index, option in enumerate(options):
            addition = ListNode(option, (options[index + 1] if index + 1 < len(options) else None))
            cur.next = addition
            cur = cur.next

        return result.next