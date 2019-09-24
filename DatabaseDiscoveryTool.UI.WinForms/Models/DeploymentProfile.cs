using System;
using System.Collections;
using System.Collections.Generic;

namespace DatabaseDiscoveryTool.UI.WinForms.Models
{
    public class DeploymentProfile
    {
        public string ProfileName { get; set; }
        public string SourceLocation { get; set; }
        public string TargetLocation { get; set; }
        public string TargetSiteName { get; set; }
        public string ApplicationPoolName { get; set; }
        public bool CleanupTempAspnetFiles { get; set; }
        public bool RestartSite { get; set; }
        public bool CopyBinFolderFiles { get; set; }
        public bool CopyPlugins { get; set; }
        public bool CopyAllFiles { get; set; }
    }

    public class ProfilesCollection : ICollection<DeploymentProfile>
    {
        private List<DeploymentProfile> _items;
        private List<DeploymentProfile> Items
        {
            get
            {
                if (this._items == null)
                {
                    lock (this)
                    {
                        if (this._items == null)
                        {
                            this._items = new List<DeploymentProfile>();
                        }
                    }
                }
                return this._items;
            }
        }


        public IEnumerator<DeploymentProfile> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(DeploymentProfile item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            Items.Add(item);
        }

        public void Clear()
        {
            if (this._items != null)
            {
                this._items.Clear();
            }
        }

        public bool Contains(DeploymentProfile item)
        {
            if (this._items != null)
            {
                return this._items.Contains(item);
            }
            return false;
        }

        public void CopyTo(DeploymentProfile[] array, int arrayIndex)
        {
            Items.CopyTo(array,arrayIndex);
        }

        public bool Remove(DeploymentProfile item)
        {
            return Items.Remove(item);
        }

        public int Count { get { return Items.Count; } }
        public bool IsReadOnly { get; protected set; }
    }
}