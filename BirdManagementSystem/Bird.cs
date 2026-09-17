using System;
using System.Collections.Generic;
using System.Text;

namespace BirdManagementSystem
{
    enum Gender
    {
        MALE,
        FEMALE
    }
    internal abstract class Bird
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }  // with enum -> acheive robustnes
        public string Species { get; set; }

        public Bird() { }
        public Bird(int id, Gender gender)
        {
            Id = id;
            Gender = gender;
        }
        public abstract void func();

        public override bool Equals(object obj)
        {
            return obj is Bird bird && Id == bird.Id && bird.Name == Name && Gender == bird.Gender && bird.Species == Species;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
