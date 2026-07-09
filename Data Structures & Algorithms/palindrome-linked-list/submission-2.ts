/**
 * Definition for singly-linked list.
 * class ListNode {
 *     constructor(val = 0, next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
class Solution {
    reverseList(head: ListNode): ListNode | null {
        if (head == null || head.next == null) return head;

        let curr = head;
        let prev = null;
        while (curr != null) {
            let next = curr.next!;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
    middleNode(head: ListNode | null): ListNode | null {
        let fast = head;
        let slow = head;

        while (fast !== null && fast.next !== null) {
            slow = slow?.next!;
            fast = fast.next?.next!;
        }

        return slow;
    }
    /**
     * @param {ListNode} head
     * @return {boolean}
     */
    isPalindrome(head: ListNode | null): boolean {
        let secondHalf = this.middleNode(head);

        let first = head;
        let second = this.reverseList(secondHalf!);

        while (second !== null) {
            if (first?.val != second.val) return false;

            first = first.next;
            second = second.next;
        }

        return true;
    }

}
