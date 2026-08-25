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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;
        Stack<ListNode> nodes = new Stack<ListNode>();
        ListNode curr = head;
        while (curr != null)
        {
            nodes.Push(curr);
            curr = curr.next;
        }
        
        int size = nodes.Count;
        curr = head;
        for (int i = 0; i < size / 2; i++) {
            ListNode next = curr.next;
            ListNode last = nodes.Pop();
            curr.next = last;
            last.next = next;
            curr = next;
        }
        curr.next = null;
    }
}
