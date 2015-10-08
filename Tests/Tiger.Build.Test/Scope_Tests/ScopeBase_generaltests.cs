using NUnit.Framework;
using Tiger.Build.Compiler.Common;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Scope_Tests
{
    /// <summary>
    /// all test of the scope base are done using <see cref="int"/>
    /// </summary>
    [TestFixture]
    [Category("ScopeBase")]
    public class ScopeBase_generaltests
    {
        [Test]
        public void child_references_to_parent()
        {
            var scope = new ScopeCollection<int>();

            ScopeBase<int> child = scope.GetChild();

            Assert.AreSame(scope, child.Parent);
        }

        [Test]
        public void contains_all_items_of_parent()
        {
            const string scope_key = "key";
            const int scope_value = 0;

            var scope = new ScopeCollection<int>();
            scope.Add(scope_key, scope_value);

            var child_scope = (ScopeCollection<int>) scope.GetChild();

            Assert.AreEqual(scope_value, child_scope[scope_key]);
        }

        [Test]
        public void contains_item_after_added()
        {
            const string scope_key = "key";
            const int scope_value = 0;

            var scope = new ScopeCollection<int>();
            scope.Add(scope_key, scope_value);

            Assert.IsTrue(scope.Contains(scope_key));
        }

        [Test]
        public void notifies_on_item_added_to_parent_scope()
        {
            const string scope_key = "key";
            const int scope_value = 0;

            var scope = new ScopeCollection<int>();

            var child_scope = (ScopeCollection<int>) scope.GetChild();

            bool itemAdded = false;
            child_scope.ItemAdded += (_, e) => { if (e.Key == scope_key) itemAdded = true; };

            scope.Add(scope_key, scope_value);

            Assert.IsTrue(itemAdded);
        }

        [Test]
        public void notifies_on_new_item_added_to_same_scope()
        {
            const string scope_key = "key";
            const int scope_value = 0;

            var scope = new ScopeCollection<int>();

            bool itemAdded = false;
            scope.ItemAdded += (_, e) => { if (e.Key == scope_key) itemAdded = true; };

            scope.Add(scope_key, scope_value);

            Assert.IsTrue(itemAdded);
        }

        [Test]
        public void returns_correct_item_after_added()
        {
            const string scope_key = "key";
            const int scope_value = 0;

            var scope = new ScopeCollection<int>();
            scope.Add(scope_key, scope_value);

            Assert.AreEqual(scope_value, scope[scope_key]);
        }
    }
}