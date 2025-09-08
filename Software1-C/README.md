Inventory:
⦁	Consists of Part(s) and Product(s)
⦁	Has a bunch of functions to add/remove/lookup/update both Part and Product
⦁	 	BindingList<Product> and BindingList<Part>

Product:
⦁	Multiple attributes
⦁	BindingList<Part>
⦁	add/remove/lookupAssociatedPart

Part <<abstract>>
⦁	bunch of attributes that are set in the children

Inherit from Part
⦁	Inhouse
⦁	 	MachineID
⦁	Outsourced
⦁	 	CompanyName