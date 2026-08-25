/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
        // Recursive
        // if (head == null)
        // {
        //     return null;
        // }
        // if (head.next == null)
        // {
        //     return head;
        // }
        // ListNode newHead = ReverseList(head.next);
        // ListNode nextNode = head.next;
        // nextNode.next = head;
        // head.next = null;
        // return newHead;
    }
}
