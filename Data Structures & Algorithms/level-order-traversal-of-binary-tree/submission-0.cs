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
    public List<List<int>> LevelOrder(TreeNode root) {

        if(root is null)
            return new List<List<int>>();

        var q = new Queue<TreeNode>();
        var result = new List<List<int>>();

        q.Enqueue(root);
        int currLevel = 0;

        while(q.Count > 0) {
            int len = q.Count;
            result.Add(new List<int>());

            for(int i = 0; i < len; i++) {
                
                var node = q.Dequeue();
                result[currLevel].Add(node.val);

                if(node.left != null) 
                    q.Enqueue(node.left);
                
                if(node.right != null)
                    q.Enqueue(node.right);
            }

            currLevel++;
        }

        return result;
    }
}
