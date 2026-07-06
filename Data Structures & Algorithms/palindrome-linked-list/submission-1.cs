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
    public bool IsPalindrome(ListNode head) {
        var stack = new Stack<int>();
        var curr = head;
        while(curr != null)
        {
            stack.Push(curr.val);
            curr = curr.next;
        }

        curr = head;
        while(curr != null) {

            if(curr.val != stack.Pop()) return false;
            
            curr = curr.next;
        }

        return true;
    }
}