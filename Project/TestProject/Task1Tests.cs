namespace TestProject
{
    internal class Task1Tests
    {
        [Test]
        public void GetIntegersFromList_ListWithTwoIntsAndOtherTypes_ReturnsListWithSameInts()
        {
            var List = new List<object>() {1, 'a', 'b', "aasf", '1', "123", 2, 12123.02,};
            var result = Tasks.Task1.GetIntegersFromList(List);
            Assert.That(result, Is.EqualTo(new List<int> { 1, 2}));
        }

        [Test]
        public void GetIntegersFromList_OnlyStringList_ReturnsEmptyList()
        {
            var List = new List<object>() {'a'};
            var result = Tasks.Task1.GetIntegersFromList(List);
            Assert.That(result, Is.EqualTo(new List<int> {}));
        }
    }
}