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

    mergeTwoLists(
        list1: ListNode | null,
        list2: ListNode | null,
    ): ListNode {
        let dummy = new ListNode(0);
        let curr = dummy;

        while (list1 !== null && list2 !== null) {
            if (list1.val < list2.val) {
                curr.next = list1;
                list1 = list1.next;
            } else {
                curr.next = list2;
                list2 = list2.next;
            }
            curr = curr.next;
        }

        if (list1 !== null) curr.next = list1;
        if (list2 !== null) curr.next = list2;
        return dummy.next!;
    }
    /**
     * @param {ListNode[]} lists
     * @return {ListNode}
     */
    mergeKLists(lists: ListNode[]): ListNode {
        if (lists === null || lists.length === 0) return null;

        let k = lists.length;
        let step = 1;
        while (step < k) {
            for (let i = 0; i + step < k; i += step * 2) {
                lists[i] = this.mergeTwoLists(lists[i]!, lists[i + step]!);
            }
            step *= 2;
        }

        return lists[0]!;
    }
}
