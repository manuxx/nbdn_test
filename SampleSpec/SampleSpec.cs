using System;
using Machine.Specifications;

namespace SampleSpec
{
    [Subject(typeof (int))]
    public class when_increasing_int 
    {
        Establish c = () => {  sut = 1; };

        Because b = () => { sut = sut + 1; };

        It should_be_equal_to_two = () => { sut.ShouldEqual(2); };

        private static int sut;
    }
}