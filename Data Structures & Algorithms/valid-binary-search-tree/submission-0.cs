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
    public bool IsValidBST(TreeNode root) {

        if(root is null) return true;

        if(root.left != null && root.val <= GetMax(root.left)) return false;

        if(root.right != null && root.val >= GetMin(root.right)) return false;

        return IsValidBST(root.left) && IsValidBST(root.right);
    }

    private int GetMax(TreeNode root) {
        if(root is null) return int.MinValue;

        int left = GetMax(root.left);
        int right = GetMax(root.right);

        return Math.Max(root.val, Math.Max(left, right));
    }

    private int GetMin(TreeNode root) {
        if(root is null) return int.MaxValue;

        int left = GetMin(root.left);
        int right = GetMin(root.right);

        return Math.Min(root.val, Math.Min(left, right));

    }
}
