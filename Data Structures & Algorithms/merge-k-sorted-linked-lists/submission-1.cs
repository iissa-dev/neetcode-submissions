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
    public ListNode MergeKLists(ListNode[] lists) {

        if(lists == null || lists.Length == 0) {
            return null;
        }

        int k = lists.Length;
        int step = 1;

        while(step < k) {
            for(int i = 0; i + step < k; i += step * 2) {
                lists[i] = MargeTwoLists(lists[i], lists[i + step]);
            }
            step *= 2;
        }
        
        return lists[0];
    }
    private ListNode MargeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        var curr = dummy;
        while(l1 is not null && l2 is not null) {
            if(l1.val < l2.val) {
                curr.next = l1;
                l1 = l1.next;
            }
            else {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }

        if(l1 != null) curr.next = l1;
        if(l2 != null) curr.next = l2;

        return dummy.next;
    }
}
