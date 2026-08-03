/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {

    private int Counter = 0;
    private int Result = 0;

    public int KthSmallest(TreeNode root, int k) {
        Traverse(root, k);
        return Result;
    }

    private void Traverse(TreeNode root, int k) {
        if(root is null || Counter >= k) return;

        Traverse(root.left, k);
        Counter++;

        if(Counter == k) {
            Result = root.val;
            return;
        }

        Traverse(root.right, k);
    }
}
