import { Component } from '@angular/core';
import {Observable} from 'rxjs';
import {Subject,BehaviorSubject,ReplaySubject,AsyncSubject} from 'rxjs';

// console.log("**********************************************");
// console.log("Observable VS Subject");
// console.log("**********************************************");

// let obs = Observable.create((observer:any)=>{
//    observer.next(Math.random());
// })

// obs.subscribe((res : any)=>{
//   console.log('subscription a :', res); //subscription a :0.2859800202682865
// });

// obs.subscribe((res : any)=>{
//   console.log('subscription b :', res); //subscription b :0.694302021731573
// });



// let obs1 = new Subject();

// obs1.subscribe(res=>{
//   console.log('subscription a :', res); // subscription a : 0.91767565496093
// });

// obs1.subscribe(res=>{
//   console.log('subscription b :', res);// subscription b : 0.91767565496093
// });

// obs1.next(Math.random());

// console.log("**********************************************");
// console.log("BEHAVIOR_SUBJECT");
// console.log("**********************************************");

// const subject2 = new BehaviorSubject(0); // 0 is the initial value
 
// subject2.subscribe({
//   next: (v:any) => console.log(`observerA: ${v}`)
// });
 
// subject2.next(1);
// subject2.next(2);
 
// subject2.subscribe({
//   next: (v:any) => console.log(`observerB: ${v}`)
// });
 
// subject2.next(3);;

// console.log("**********************************************");
// console.log("REPLAY_SUBJECT");
// console.log("**********************************************");

// const subject = new ReplaySubject(2); // buffer 3 values for new subscribers
 
// subject.subscribe({
//   next: (v) => console.log(`observerA: ${v}`)
// });
 
// subject.next(1);
// subject.next(2);
// subject.next(3);
 


// subject.subscribe({
//   next: (v) => console.log(`observerB: ${v}`)
// });

// subject.next(4);
// subject.next(5);;


// const subject1 = new AsyncSubject();

// subject1.subscribe({
//   next: (v) => console.log(`observerA: ${v}`)
// });

// subject1.next(1);
// subject1.next(2);
// subject1.next(3);
// subject1.next(4);

// subject1.subscribe({
//   next: (v) => console.log(`observerB: ${v}`)
// });

// subject1.next(5);
// subject1.complete();;


// console.log("**********************************************");
// console.log("VOID_SUBJECT");
// console.log("**********************************************");

// const subject3 = new Subject(); // Shorthand for Subject<void>

// subject3.subscribe({
//   next: () => console.log('One second has passed')
// });

// setTimeout(() => subject3.next(0), 1000);;

let promise = new Promise((resolve, reject) => {
  reject('Promise rejected!')
});


promise.catch(error => console.log(error));
promise.catch(error => console.log(error));

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'RxJS';
}



