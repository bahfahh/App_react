
import {Dog ,Animals } from './demo';

interface props {
    dog:Dog
}

export default function App (props: props) {
  return (
    <div key={props.dog.serialNumber}>
      
    <button onClick={() => props.dog.makeSound("Woof")}>Woof</button>
    </div>
    
  )
}

//TODO
//實際上是可以直接使用 interface 是更有規範點
// export default function App({ dog }: { dog: Dog }) {
//   return (
//     <div key={dog.serialNumber}>
//       <button onClick={() => dog.makeSound("Woof")}>Woof</button>
//     </div>
//   )
// }
