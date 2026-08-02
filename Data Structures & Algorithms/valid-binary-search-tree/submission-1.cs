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

    private long prev = long.MinValue;

    public bool IsValidBST(TreeNode root) {
        if(root is null) return true;
        if(!IsValidBST(root.left)) return false;

        if(root.val <= prev) return false;

        prev = root.val;


        return IsValidBST(root.right);
      
    }

}
