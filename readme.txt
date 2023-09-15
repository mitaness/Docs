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

