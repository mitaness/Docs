9:39 AM 9/10/2023
refresher angular Deborah

"C:\test1\test\ts4\node_modules\bootstrap\dist\css\bootstrap.css"

bootstrap
npm install bootstrap
in styles.css
@import "~bootstrap/dist/css/bootstrap.css"

built-in directives
* - structural directives
*ngIf
*ngFor

*ngIf='products.length'
*ngFor='let product of products'

property binding
<img [src]='prop'

module declaration is like a project file csproj

page-life cycle hooks
OnInit - after Angular has initialized the data-bound properties
OnChanges
OnDestroy

- building a custom pipe
task: replace a given character to space
No pipe found with name 'convertTo2'
- declare in the same module a component of which needs the pipe

check out
9:29 AM 9/11/2023
      <table>
      <tr *ngFor="let p of products | async">
        <td>{{ p.productName }}</td>
        <td>{{ p.id }}</td>
        <td><a routerLink="/products/{{ p.id }}/edit">Edit</a></td>
        <td><a routerLink="/products/:id/edit">Edit</a></td>
        <td><a [routerLink]="['/products', p.id]">Detail</a></td>
        <td><a routerLink="/products/{{ p.id }}/edit">Detail --</a></td>
        <td><a [routerLink]="['/products', p.id, 'edit']">Edit 2</a></td>
      </tr>
    </table>
  data: Product[] = [
    { id: 1, productName: 'Leaf Rake', productCode: 'GDN-0011', releaseDate: 'Jun 2024', price: '19.95' },
    { id: 2, productName: 'Garden Cart', productCode: 'GDN-0023', releaseDate: 'May 2025', price: '43.95' },
  ]

11:12 AM 9/16/2023
decorators deco

@Component({ selector: '', ... })
 @Input() rating = 0;
 @Output() nofify: EventEmitter<number> = new EventEmitter<number>()

C:\test1\test\ts4>ng g s productService --dry-run
CREATE src/app/product-service.service.ts (143 bytes)

Note. no modification to angular module
Root application injector
Ang has an injector for each component

@Injectable({
  providedIn: 'root'
})

-- register for a component and it's children only
@Component({
 providers: [ProductService]
})

providedIn is a new syntax, before
@NgModule({ providers: [...]}) - old syntax

-------------

@Injectable({
  providedIn: 'Root' --capitalize
})

Error: src/app/product-service.service.ts:4:3 - error TS2820: Type '"Root"' is not assignable to type 'Type<any> | "root" | "platform" | "any" | null'. Did you mean '"root"'?

@Injectable()
NullInjectorError: No provider for ProductService!

GET http://localhost:4200/api/products
  productURL = 'api/products'

8:40 AM 9/17/2023 
https://material.angular.io/guide/getting-started
ajden towfeek
Install angular material
ng add @angular/material

changes
angular.json
added line
"@angular/material/prebuilt-themes/indigo-pink.css"
compare with styles.css
@import "~bootstrap/dist/css/bootstrap.css"

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }