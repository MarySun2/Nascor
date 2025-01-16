import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ApexRoutingModule } from './apex-routing.module';
import { NavbarComponent } from './page/navbar/navbar.component';


@NgModule({
  declarations: [
    NavbarComponent
  ],
  imports: [
    CommonModule,
    ApexRoutingModule //agregado
  ],
 exports: [NavbarComponent], // agregado
})
export class ApexModule { }
