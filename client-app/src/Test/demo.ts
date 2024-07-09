let date: number = 42;
const PI = 3.14159;
// PI = 3; // 錯誤,不能重新賦值
export interface Dog{
    name: string;
    serialNumber: number;
    makeSound: (sound: string) => void;

}

const duck = {
  name: "duck",
  age: 5,
  makeSound: (sound: string) => console.log(sound),
};
const bigDog: Dog = {
  name: "bigDog",
  serialNumber: 1,
  makeSound: (sound: string) => console.log(sound),
};

const obj = { prop: 123 };
obj.prop = 456;

export const Animals = [duck, bigDog];