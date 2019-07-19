import { Component, Inject, Injector } from '@angular/core';
import { Router } from '@angular/router';
import { ReuseTabService } from '@delon/abc';

@Component({
  selector: 'emes-base',
  template: ``,
})
export class BaseComponent {
  constructor(public injector: Injector) {}

  close($event) {
    this.injector.get(ReuseTabService).close(this.injector.get(Router).url);
  }
}
