
export class RelationSchema {

  public name: string = '';

  public primaryEntityName: string = '';
  public foreignEntityName: string = '';
  public foreignKeyIndexName: string = '';

  public isLookupRelation: boolean = true;
  public primaryEntityIsOptional: boolean = false;
  public foreignEntityIsMultiple: boolean = true;

  public primaryNavigationName: string = '';
  public foreignNavigationName: string = '';
  public primaryNavigationSummary: string = '';
  public foreignNavigationSummary: string = '';

  public cascadeDelete: boolean = false;

}
