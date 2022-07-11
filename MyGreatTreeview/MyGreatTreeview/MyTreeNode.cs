using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGreatTreeview
{
    internal class MyTreeNode
    {
        public TreeNode ScanDir(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException("Toto n'a pas trouvé le répertoire " + path);
            }

            EnumerationOptions options = new EnumerationOptions()
            {
                IgnoreInaccessible = true, // RecurseSubdirectories = true
            };

            TreeNode tree = new TreeNode(Path.GetFileName(path));
            string[] result = Directory.GetDirectories(path, "*", options);

            foreach (string aDirectory in result)
            {
                //tree.Nodes.Add(aDirectory);
                TreeNode child = ScanDir(aDirectory);
                tree.Nodes.Add(child);
            }

            foreach(string aFile in Directory.GetFiles(path, "*", options))
            {
                tree.Nodes.Add(Path.GetFileName(aFile));
            }

            return tree;
        }
    }
}
