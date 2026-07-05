
class Solution {
    /**
     * @param {ListNode} head
     * @return {ListNode}
     */
    reverseList(head: ListNode | null): ListNode {
        if (head == null || head.next == null) return head;

        let newHead = this.reverseList(head.next);

        head.next.next = head;
        head.next = null;

        return newHead;
    }
}
